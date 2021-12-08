import React, { useState, useEffect } from 'react';
import { Grid, makeStyles } from '@material-ui/core'
import Form from "../../layouts/Form"
import { Input, Select, Button } from '../../controls'
import { ENDPOINTS, createAPIEndpoint } from "../../api";

const useStyles = makeStyles(theme => ({
    buttons: {
        color: '#ffffff',
        textShadow: "0px 0px 5px #000000",
        backgroundImage: "linear-gradient(61deg, #000000 12.82%, #ffee00 12.82%, #ffee00 25.64%, #000000 25.64%, #000000 30.77%, #ffee00 30.77%, #ffee00 50%, #000000 50%, #000000 62.82%, #ffee00 62.82%, #ffee00 75.64%, #000000 75.64%, #000000 80.77%, #ffee00 80.77%, #ffee00 100%);",
        backgroundSize: "78.00px 140.72px",
        width: '42%',
        boxShadow: "0px 0px 5px #ffffff",
        "&:hover": {
            boxShadow: "0px 0px 12px #ffffff"
        }
    },
    listGamesButton: {
        color: '#ffffff',
        textShadow: "0px 0px 3px #000000",
        backgroundImage: "linear-gradient(61deg, #000000 12.82%, #ffee00 12.82%, #ffee00 25.64%, #000000 25.64%, #000000 30.77%, #ffee00 30.77%, #ffee00 50%, #000000 50%, #000000 62.82%, #ffee00 62.82%, #ffee00 75.64%, #000000 75.64%, #000000 80.77%, #ffee00 80.77%, #ffee00 100%);",
        backgroundSize: "78.00px 140.72px",
        width: '90%',
        boxShadow: "0px 0px 5px #ffffff",
        "&:hover": {
            boxShadow: "0px 0px 12px #ffffff"
        }
    }
}))

export default function GameForm(props) {

    const { values, errors, onInputChanged, resetFormControls } = props;
    const classes = useStyles();

    const [customerList, setCustomerList] = useState([])
    const [locationList, setLocationList] = useState([])
    useEffect(() => {
        createAPIEndpoint(ENDPOINTS.CUSTOMER).fetchAll()
            .then(res => {
                let customerList = res.data.map(item => ({
                    id: item.customerId,
                    title: item.full_name
                }))
                customerList = [{ id: 0, title: 'Select' }].concat(customerList);
                setCustomerList(customerList);
            }).catch(err => console.error(err))
    }, [])
    useEffect(() => {
        createAPIEndpoint(ENDPOINTS.LOCATION).fetchAll()
            .then(res => {
                let locationList = res.data.map(item => ({
                    id: item.locationId,
                    title: item.name
                }))
                locationList = [{ id: 0, title: 'Select' }].concat(locationList);
                setLocationList(locationList);
            }).catch(err => console.error(err))
    }, [])

    const submitGame = e => {
        e.preventDefault();
        createAPIEndpoint(ENDPOINTS.GAME).create(values)
            .then(res => {
                resetFormControls();
            }).catch(err => console.error(err))
    }

    return (
        <Form onSubmit={submitGame}>
            <Grid container spacing={2}>
                <Grid item xs={4}>
                    <Select
                        label="Customer"
                        name="customerId"
                        value={values.customerId}
                        onChange={onInputChanged}
                        options={customerList}
                    />
                </Grid>
                <Grid item xs={4}>
                    <Select
                        label="Location"
                        name="locationId"
                        value={values.locationId}
                        onChange={onInputChanged}
                        options={locationList}
                    />
                </Grid>
                <Grid item xs={4}>
                    <Input
                        label="Players Count"
                        name="pCount"
                        value={values.pCount}
                    />
                    <Input
                        disabled
                        label="Full Value"
                        name="fullValue"
                        value={values.fullValue}
                    />
                    <Button
                        className={classes.buttons}
                        size="large" type="submit">
                        Confirm
                    </Button>
                    <Button
                        className={classes.buttons}
                        size="large" type="submit">
                        Reset
                    </Button>
                    <Button
                        className={classes.buttons, classes.listGamesButton}
                        size="large" type="submit">
                        List Games
                    </Button>
                </Grid>
            </Grid>
        </Form >
    )
}