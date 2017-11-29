import * as React from 'react';
import {RouteComponentProps} from 'react-router-dom';

export default class Home extends React.Component<RouteComponentProps<{}>, {}> {
  public render() {
    return (
      <div className="page-content-wrapper">
        <div className="page-content-inner">

          <div id="page-header" className="clearfix">
            <div className="page-header">
              <h2>Bảng theo dõi</h2>
              <span className="txt">Bảng theo dõi thông tin hệ thống</span>
            </div>
            <div className="header-stats">
              <div className="spark clearfix">
                <div className="spark-info"><span className="number">2345</span>Visitors</div>
                <div id="spark-visitors" className="sparkline"></div>
              </div>
              <div className="spark clearfix">
                <div className="spark-info"><span className="number">17345</span>Views</div>
                <div id="spark-templateviews" className="sparkline"></div>
              </div>
              <div className="spark clearfix">
                <div className="spark-info"><span className="number">3700$</span>Sales</div>
                <div id="spark-sales" className="sparkline"></div>
              </div>
            </div>
          </div>
          <div className="row">
          </div>
        </div>
      </div>);
  }
}
