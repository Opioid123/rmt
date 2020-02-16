import {ADD_RESOURCES} from '../constants/action-types';

export function addResources(payload) {
    return { type: "ADD_RESOURCES", payload }
  };

export function getData() {
return function(dispatch) {
    return fetch("http://https://localhost:5001/rmt")
    .then(response => response.json())
    .then(json => {
        dispatch({ type: "DATA_LOADED", payload: json });
    });
};
}