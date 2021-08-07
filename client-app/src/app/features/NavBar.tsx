import React from 'react'
import { Button, Container, Menu } from 'semantic-ui-react'

export default function NavBar() {
    return (
        <Menu inverted fixed='top'>
            <Container>
                <Menu.Item header>
                    <img src='/assets/images/logo.png' alt="logo" style={{ marginRight: '10px' }} />
                    Temple Fundraisers
                </Menu.Item>
                <Menu.Item name="Fundraisers"></Menu.Item>
                <Menu.Item>
                    <Button positive content="Create Fundraiser" />
                </Menu.Item>
            </Container>
        </Menu>
    )
}
