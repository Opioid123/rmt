import { createStore, applyMiddleware} from "redux";
import rootReducer from "../reducers/index";
import thunk from "redux-thunk";
import freeze from 'redux-freeze';
import createLogger from 'redux-logger';
import _ from 'lodash';

const logger = createLogger();
const middlewares = _.compact([thunk, freeze, logger]);
const createStoreWithMiddleware = applyMiddleware(...middlewares)(createStore);
const store = createStoreWithMiddleware(rootReducer)

export default store;
