import React, { useState, useEffect } from 'react';
import { ENDPOINTS, createAPIEndpoint } from "../../api";
import { Grid, List, ListItem, ListItemText, Paper, InputBase, IconButton, makeStyles, ListItemSecondaryAction } from '@material-ui/core';
import PlusOneIcon from '@material-ui/icons/PlusOne';
import ArrowForwardIosIcon from '@material-ui/icons/ArrowForwardIos';

const useStyles = makeStyles(theme => ({
    searchPaper: {
        padding: '2px 4px',
        display: 'flex',
        alignItems: 'center',
    },
    searchInput: {
        marginLeft: theme.spacing(1.5),
        flex: 1,
        color: "rgba(15, 15, 15, 1)!important",
    },
    listRoot: {
        margin: theme.spacing(1),
        maxHeight: 450,
        overflow: 'auto',
        border: '1px solid rgba(255, 255, 255, 0.25)',
        borderRadius: '5px',
        '& li:hover': {
            cursor: 'pointer',
            backgroundColor: '#000000'
        },
        '& li:hover .MuiButtonBase-root': {
            display: 'block',
            color: '#fff',
        },
        '& .MuiButtonBase-root': {
            display: 'none'
        },
        '& .MuiButtonBase-root:hover': {
            backgroundColor: 'transparent'
        }
    }
}))

export default function SearchEquipment(props) {
    const { values, setValues } = props;
    let equipmentUsed = values.equipmentUsages;

    const addEquipmentUsage = eq => {
        let x = {
            gameId: values.gameId,
            equipmentUsageId: 0,
            equipmentId: eq.equipmentId,
            number: 1,
            snapPrice: eq.price,
            equipmentName: eq.name
        }
        setValues({
            ...values,
            equipmentUsages: [...values.equipmentUsages, x]
        })
    }

    const [equipment, setEquipment] = useState([]);
    const classes = useStyles();
    const [searchKey, setSearchKey] = useState('');
    const [searchList, setSearchList] = useState([]);

    useEffect(() => {
        createAPIEndpoint(ENDPOINTS.EQUIPMENT).fetchAll()
            .then(res => {
                setEquipment(res.data)
                setSearchList(res.data)
            }).catch(err => { console.error(err) })
    }, []);

    useEffect(() => {
        let list = [...equipment];
        list = list.filter(obj => {
            return obj.name.toLowerCase().includes(searchKey.toLocaleLowerCase())
                && equipmentUsed.every(item => item.equipmentId != obj.equipmentId)
        })
        setSearchList(list)
    }, [searchKey, equipmentUsed])

    return (
        <>
            <Paper className={classes.searchPaper}>
                <InputBase className={classes.searchInput}
                    placeholder="Search equipment"
                    value={searchKey}
                    onChange={e => setSearchKey(e.target.value)}
                />
            </Paper>
            <List className={classes.listRoot}>
                {
                    searchList.map((item, idx) => (
                        <ListItem key={idx}>
                            <ListItemText
                                primary={item.name}
                                secondary={item.price + '₴'}
                            />
                            <ListItemSecondaryAction>
                                <IconButton onClick={e => addEquipmentUsage(item)}>
                                    <PlusOneIcon />
                                    <ArrowForwardIosIcon />
                                </IconButton>
                            </ListItemSecondaryAction>
                        </ListItem>
                    ))
                }
            </List>
        </>
    )
}