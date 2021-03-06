import React from 'react';
import { Route } from 'react-router';
import { Layout } from './components/Layout';
import { Home } from './pages/home/Home';
import { FetchData } from './components/FetchData';
import { Counter } from './components/Counter';

import './styles/globals.css';

export default function App() {
  return (
    <Layout>
      <Route exact path="/" component={Home} />
      <Route path="/counter" component={Counter} />
      <Route path="/fetch-data" component={FetchData} />
    </Layout>
  );
}
