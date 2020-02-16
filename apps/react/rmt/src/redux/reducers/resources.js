import {ADD_RESOURCES} from '../constants/action-types';
import {DATA_LOADED} from '../constants/action-types';

const initialState = {
    // resources: {
    //     resourceList:[]
    // }
  };
const resources = (state = initialState, action) => {
switch(action.type){
    // case ADD_RESOURCES:
    //   return {
    //     ...state,
    //     resources: [...state.resources, action.payload]
    //   }
    // case DATA_LOADED:
    //   return {
    //     ...state,
    //     resources: [...state.resources, action.payload]
    //   }
    default:
        return state
    }
}

export default resources;
  