import React, { useState, useEffect } from 'react';
import { List, ListItemText, Paper, ListItem, ListItemSecondaryAction, IconButton, ButtonGroup, Button, makeStyles } from '@material-ui/core';
import DeleteOutlineIcon from '@material-ui/icons/DeleteOutline';

const useStyles = makeStyles(theme => ({
    listItem: {
        padding: '10px 20px',
        display: 'flex',
        alignItems: 'center',
        marginBottom: theme.spacing(1.5)
    },
    paperRoot: {
        margin: '15px 0px',
        '&:hover': {
            cursor: 'pointer'
        },
        '&:hover $deleteButton': {
            display: 'block'
        }
    },
    buttonGroup: {
        backgroundColor: '#E3E3E3',
        borderRadius: 8,
        '& .MuiButtonBase-root ': {
            border: 'none',
            minWidth: '25px',
            padding: '1px'
        },
        '& button:nth-child(2)': {
            fontSize: '1.2em',
            color: '#000'
        }
    },
    deleteButton: {
        display: 'none',
        '& .MuiButtonBase-root': {
            color: '#E81719'
        },
    },
    totalPerItem: {
        fontWeight: 'bolder',
        fontSize: '1.2em',
        margin: '0px 10px'
    }
}))

export default function EquipmentUsed(props) {
    const { values, setValues } = props;
    let equipmentUsed = values.equipmentUsages;
    const classes = useStyles();

    const updateNumber = (idx, value) => {
        let x = { ...values };
        let equipment = x.equipmentUsages[idx];
        if (equipment.number + value > 0) {
            equipment.number += value;
            setValues({ ...x });
        }
    }

    const removeEquipmentUsage = (index, id) => {
        let x = { ...values }
        x.equipmentUsages = x.equipmentUsages.filter((item, i) => i != index)
        setValues({ ...x })
    }

    return (
        <List>
            {
                equipmentUsed.map((item, idx) => (
                    <Paper key={idx}>
                        <ListItem className={classes.listItem}>
                            <ListItemText
                                primary={item.equipmentName}
                                primaryTypographyProps={{
                                    component: 'h1',
                                    style: {
                                        fontWeight: '500',
                                        fontSize: '1.2em'
                                    }
                                }}
                                secondary={
                                    <>
                                        <ButtonGroup
                                            className={classes.buttonGroup}
                                            size="small">
                                            <Button
                                                onClick={e => updateNumber(idx, -1)}
                                            >-</Button>
                                            <Button
                                                disabled
                                            >{item.number}</Button>
                                            <Button
                                                onClick={e => updateNumber(idx, 1)}
                                            >+</Button>
                                        </ButtonGroup>
                                        <span className={classes.totalPerItem}>
                                            {(item.number * item.snapPrice) + '₴'}
                                        </span>
                                    </>
                                }
                            />
                            <ListItemSecondaryAction>
                                <IconButton
                                    disableRipple
                                    onClick={e => removeEquipmentUsage(idx, item.equipmentUsageId)}>
                                    <DeleteOutlineIcon />
                                </IconButton>
                            </ListItemSecondaryAction>
                        </ListItem>
                    </Paper>
                ))
            }
        </List>
    )

}