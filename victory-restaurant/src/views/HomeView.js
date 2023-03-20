import React from "react"
import BannerComponent from "../components/BannerComponent"
import CookDeleciousBannerComponent from "../components/CookDeleciousBannerComponent"
import BookingComponent from "../components/BookingComponent"
import HeaderMenuComponent from "../components/HeaderMenuComponent"
import FooterComponent from "../components/FooterComponent"

function HomeView() {
    return (
        <>
        <HeaderMenuComponent />
        <BannerComponent />
        <CookDeleciousBannerComponent />
        <BookingComponent />
        <FooterComponent />
        </>
    )
}

export default HomeView