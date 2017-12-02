import * as React from 'react';
import { Route } from 'react-router-dom';
import { Layout } from './components/Layout';
import Home from './components/Home';
import Dashboard from './components/Dashboard'
import FetchData from './components/FetchData';
import Counter from './components/Counter';
import { AdminRoutePath } from './commons/constant'

export const routes = <Layout>
    <Route exact path='/' component={ Home } />
    <Route path='/counter' component={ Counter } />
    <Route path='/fetchdata/:startDateIndex?' component={FetchData} />
    <Route path={AdminRoutePath.Dashboard} component={Dashboard} />
</Layout>;
