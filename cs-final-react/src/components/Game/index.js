import React from 'react';
import GameForm from './GameForm'
import { useForm } from '../../hooks/useForm'

const newGameObject = () => ({
    gameId: 0,
    customerId: 0,
    locationId: 0,
    fullValue: 0,
    pCount: 0,
    equipmentUsage: []
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
        <GameForm
            {...{ values, errors, onInputChanged }}
        />
    )
}