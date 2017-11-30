import * as React from 'react';

export interface thisProps {
    header: string,
    description?: string
}

export class ContentHeader extends React.Component<thisProps, {}>{

  render() {
        return (
            <div id="page-header" className="clearfix">
                <div className="page-header">
                    <h2>{this.props.header || ''}</h2>
                    <span className="txt">{this.props.description || ''}</span>
                </div>  
            </div>);
    }
}