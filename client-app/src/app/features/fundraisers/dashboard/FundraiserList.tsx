import React from "react";
import { Button, Card, Progress, Image, Icon } from "semantic-ui-react";
import { Fundraiser } from "../../../models/fundraiser";

interface Props {
    fundraisers: Fundraiser[];
}

export default function FundraiserList({ fundraisers }: Props) {
    return (
        // <Segment>
        //     <Item.Group divided relaxed='very'>
        //         {fundraisers.map(fundraiser => (
        //             <Item key={fundraiser.id}>
        //                 <Item.Content>
        //                     <Item.Header as='a'>{fundraiser.name}</Item.Header>
        //                     <Button content='View' positive floated='right' />
        //                     <Item.Meta>{fundraiser.startDate}</Item.Meta>
        //                     <Item.Description>{fundraiser.description}</Item.Description>
        //                     <Item.Extra>
        //                         <Progress value={fundraiser.currentAmount} total={fundraiser.targetAmount} color='green' progress='ratio'></Progress>
        //                     </Item.Extra>
        //                 </Item.Content>
        //             </Item>
        //         ))}
        //     </Item.Group>
        // </Segment >
        <Card.Group>
            {fundraisers.map(fundraiser => (

                <Card key={fundraiser.id}>
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
            ))}
        </Card.Group>
    )
}