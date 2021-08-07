import React from "react";
//import { Grid } from "semantic-ui-react";
import { Fundraiser } from "../../../models/fundraiser";
//import FundraiserDetail from "../details/FundraiserDetail";
import FundraiserList from "./FundraiserList";

interface Props {
    fundraisers: Fundraiser[];
}

export default function FundraiserDashboard({ fundraisers }: Props) {
    return (
        // <Grid>
        //     <Grid.Column>
        //         <FundraiserList fundraisers={fundraisers} />
        //     </Grid.Column>
        // </Grid>
        <FundraiserList fundraisers={fundraisers} />
    )
}