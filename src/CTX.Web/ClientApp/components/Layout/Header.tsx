import * as React from 'react';

export class Header extends React.Component<{}, {}> {
    render() {
        return (
            <div id="header" className="page-navbar">
                <a href="/admin" className="navbar-brand hidden-xs hidden-sm logo logo-title">
                    <img src="/images/admin_logo.png" className="logo hidden-xs" alt="CTX Admin" />
                    <img src="" className="logo-sm hidden-lg hidden-md" alt="CTX Admin" />
                </a>
                <div id="navbar-no-collapse" className="navbar-no-collapse">
                    <ul className="nav navbar-nav">
                        <li className="toggle-sidebar">
                            <a href="#">
                                <i className="fa fa-reorder"></i>
                                <span className="sr-only">Collapse sidebar</span>
                            </a>
                        </li>
                    </ul>
                    <ul className="nav navbar-nav navbar-right">
                        <li>
                            <a onClick={() => this.logOut()}>
                                <i className="fa fa-power-off" title="Sign out"></i>
                                <span className="sr-only">Logout</span>
                            </a>
                        </li>
                    </ul>
                </div>
            </div>
        );
    }

    private async logOut() {

        // let result = await SweetAlerts.show({
        //     title: 'Xác nhận',
        //     text: 'Bạn có muốn đăng xuất?',
        //     type: SweetAlertTypeEnums.Warning,
        //     showCancelButton: true,
        //     confirmButtonText: 'Đăng xuất!',
        //
        // });
        // if (result == SweetAlertResultEnums.Confirm) {
        //     store.dispatch(logOutAction());
        // }
    }
}