import React from "react";
import { Card, Icon, Progress, Image, Button } from "semantic-ui-react";
import { Fundraiser } from "../../../models/fundraiser";

interface Props {
    fundraiser: Fundraiser
}

export default function FundraiserDetail({ fundraiser }: Props) {
    return (
        <Card>
            <Image src={`/assets/images/templeImages/${fundraiser.image}`} wrapped />
            <Card.Meta>{fundraiser.startDate}</Card.Meta>
            <Card.Content extra>
                <Card.Header>{fundraiser.name}</Card.Header>
                <Progress value={fundraiser.currentAmount} total={fundraiser.targetAmount} color='green' progress='ratio'></Progress>
                <Card.Description>{fundraiser.description}</Card.Description>
                <Button>
                    <Icon name='user' />
                    22 Contributors
                </Button>
            </Card.Content>
        </Card>
    )
}