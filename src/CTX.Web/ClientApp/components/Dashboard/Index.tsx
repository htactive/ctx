import * as React from 'react';
import { RouteComponentProps } from 'react-router-dom';
import {ContentHeader} from "../Commons/ContentHeader";
export default class Dashboard extends React.Component<RouteComponentProps<{}>,{}> {

  render(){
      return (
          <div>
            <ContentHeader header='Bảng theo dõi' description='Theo dõi thông tin hệ thống'/>
          </div>
    );
  }
}