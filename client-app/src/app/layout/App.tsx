import React, { Fragment, useEffect, useState } from 'react';
import { Container } from 'semantic-ui-react';
import agent from '../api/agent';
import FundraiserDashboard from '../features/fundraisers/dashboard/FundraiserDashboard';
import NavBar from '../features/NavBar';
import { Fundraiser } from '../models/fundraiser';
import LoadingComponent from './LoadingComponent';
import './styles.css';

function App() {
  const [fundraisers, setFundraisers] = useState<Fundraiser[]>([]);
  const [loading, setLoading] = useState(true);

  useEffect(() => {
    agent.Fundraisers.list().then(
      response => {
        let fundraisers: Fundraiser[] = [];
        response.forEach(fundraiser => {
          fundraiser.startDate = fundraiser.startDate.split('T')[0];
          fundraisers.push(fundraiser);
        })
        setFundraisers(fundraisers);
        setLoading(false);
      }
    )
  }, [])

  if (loading) return <LoadingComponent content='Loading app ' />
  return (
    <Fragment>
      <NavBar />
      <Container style={{ marginTop: '7em' }}>
        <FundraiserDashboard fundraisers={fundraisers} />
      </Container>

    </Fragment>
  );
}

export default App;
