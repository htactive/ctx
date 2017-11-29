import * as React from 'react';
import { NavMenu } from './NavMenu';
import {Header} from './Header';
import {Footer} from './Footer';
import {LeftSideBar} from "./LeftSideBar";

export class Layout extends React.Component<{}, {}> {
    public render() {
        return  <div>
            <Header/>
            <div id="wrapper">
                <LeftSideBar/>
                <div className="page-content sidebar-page clearfix">
                  {this.props.children}
                </div>
            </div>
            <Footer/>
        </div>;
    }
}
