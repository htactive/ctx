import * as React from 'react'
import { NavLink, Link } from 'react-router-dom';
import {AdminRoutePath} from "../../commons/constant";

export class LeftSideBar extends React.Component<{},{}>{

    render(){
        return(
          <aside id="sidebar" className="page-sidebar hidden-md hidden-sm hidden-xs">
              <div className="sidebar-inner">
                  <div className="sidebar-scrollarea">
                      {/*<div className="sidebar-panel">*/}
                          {/*<h5 className="sidebar-panel-title">Hồ sơ</h5>*/}
                      {/*</div>*/}
                      {/*<div className="user-info clearfix">*/}
                        {/*{this.renderAvatar()}*/}
                          {/*<Link to={AdminRoutePath.UserProfile} className="name">*/}
                            {/*{this.state.CurrentUser.UserProfiles[0].FullName}*/}
                          {/*</Link>*/}
                      {/*</div>*/}
                      <div className="sidebar-panel">
                          <h5 className="sidebar-panel-title">Điều hướng</h5>
                      </div>
                      <div className="side-nav">
                          <ul className="nav">
                              <li>
                                  <NavLink exact to={AdminRoutePath.Dashboard } activeClassName='active'>
                                      <i className="fa fa-home"></i><span className="txt">Bảng theo dõi</span>
                                  </NavLink>
                              </li>
                              <li>
                                  <NavLink to={AdminRoutePath.Dashboard } activeClassName='active'>
                                      <i className="fa fa-home"></i><span className="txt">Bảng theo dõi</span>
                                  </NavLink>
                              </li>
                              <li>
                                  <NavLink exact to={ AdminRoutePath.Dashboard } activeClassName='active'>
                                      <i className="fa fa-home"></i><span className="txt">Bảng theo dõi</span>
                                  </NavLink>
                              </li>
                          </ul>
                      </div>
                  </div>
              </div>
          </aside>
       )
}
}