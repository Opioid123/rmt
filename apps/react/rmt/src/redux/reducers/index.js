import resources from '../reducers/resources.js'
import {combineReducers} from 'redux';

const rootReducer = combineReducers({
  resources: resources
})

export default rootReducer;
  