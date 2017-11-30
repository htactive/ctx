import * as React from 'react';
import {RouteComponentProps} from 'react-router-dom';
import {ContentHeader} from "../Commons/ContentHeader";


export default class Home extends React.Component<RouteComponentProps<{}>, {}> {
  public render() {
    return (
      <div className="page-content-wrapper">
        <div className="page-content-inner">
            <ContentHeader header='Trang chủ'  />
        </div>
      </div>);
  }
}
