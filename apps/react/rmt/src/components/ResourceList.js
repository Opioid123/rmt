import React, {Component} from 'react';
import './ResourceList.css';
import 'primereact/resources/themes/nova-light/theme.css';
import 'primereact/resources/primereact.min.css';
import 'primeicons/primeicons.css';
import {DataTable} from 'primereact/datatable';
import {connect} from 'react-redux';
import {getData} from '../redux/actions/index'
import {Column} from 'primereact/column';


const cols = [
    {field: 'ldap', header: 'LDAP'},
    {field: 'name', header: 'Name'},
    {field: 'id', header: 'Id'},
    {field: 'role', header: 'Role'},
]

const dynamicColumns = cols.map((col, i) =>{
    return <Column key={col.field} field={col.field} header={col.header} sortable={true} />;
})

export class ResourceList extends Component {
    componentDidMount() {
      this.props.getData();
    }
    
    render() {
      return (
        <DataTable value={this.props.resources}>{dynamicColumns}</DataTable>
      );
    }
  }
  function mapStateToProps(state) {
    return {
        resources: state.resources
    };
  }
  export default connect(
    mapStateToProps,
    { getData }
  )(ResourceList);
