import React from "react"
import HeaderMenuComponent from "../components/HeaderMenuComponent"
import FooterComponent from "../components/FooterComponent"
import PageHeadingComponent from "../components/PageHeadingComponent"
import CreateContactMessageComponent from "../components/CreateContactMessageComponent"
import GoogleMapComponent from "../components/GoogleMapComponent"

function ContactView() {
    return (
        <>
        <HeaderMenuComponent />
        <PageHeadingComponent header = "Contact Us" text = "Ask us your questions and we will definitely answer them."/>
        <CreateContactMessageComponent />
        <GoogleMapComponent/>
        <FooterComponent />
        </>
    )
}

export default ContactView