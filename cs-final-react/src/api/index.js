import axios from "axios";

const root_url = "http://localhost:39777/api/";

export const ENDPOINTS = {
    CUSTOMER: "Customer",
    LOCATION: "Location",
    GAME: "Game",
    EQUIPMENT: "Equipment"
}

export const createAPIEndpoint = endpoint => {

    let url = root_url + endpoint + '/'

    return {
        fetchAll: () => axios.get(url),
        fetchById: (id) => axios.get(url + id),
        create: (newRecord) => axios.post(url, newRecord),
        update: (id, updatedRecord) => axios.put(url + id, updatedRecord),
        delete: (id) => axios.delete(url + id)
    }
}