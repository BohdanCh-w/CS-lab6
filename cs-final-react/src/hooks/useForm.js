import React, { useState } from 'react'

export function useForm(newModelObject) {

    const [values, setValues] = useState(newModelObject());
    const [errors, setErrors] = useState({});

    const onInputChanged = e => {
        const { name, value } = e.target
        setValues({
            ...values,
            [name]: value
        })
    }

    const resetFormControls = () => {
        setValues(newModelObject());
        setErrors({})
    }

    return {
        values,
        setValues,
        errors,
        setErrors,
        onInputChanged,
        resetFormControls
    }
}
