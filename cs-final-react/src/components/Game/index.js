import React from 'react';
import GameForm from './GameForm'
import EquipmentUsed from './EquipmentUsed'
import SearchEquipment from './SearchEquipment'
import { useForm } from '../../hooks/useForm'
import { Grid, makeStyles } from '@material-ui/core'

const newGameObject = () => ({
    gameId: 0,
    customerId: 0,
    locationId: 0,
    fullValue: 0,
    pCount: 0,
    equipmentUsages: []
});

export default function Game() {

    const {
        values,
        setValues,
        errors,
        setErrors,
        onInputChanged,
        resetFormControls
    } = useForm(newGameObject);

    return (
        <Grid container spacing={2}>
            <Grid item xs={12}>
                <GameForm
                    {...{ values, errors, onInputChanged, resetFormControls }}
                />
            </Grid>
            <Grid item xs={6}>
                <SearchEquipment
                    {...{
                        values,
                        setValues
                    }}
                />
            </Grid>
            <Grid item xs={6}>
                <EquipmentUsed
                    {...{
                        values,
                        setValues
                    }}
                />
            </Grid>
        </Grid>
    )
}