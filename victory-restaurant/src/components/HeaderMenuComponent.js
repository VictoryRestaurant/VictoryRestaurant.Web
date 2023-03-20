import React from "react"

const homeButtonOnClick = () =>{
    window.location.href = '/';
}

const menuButtonOnClick = () =>{
    window.location.href = '/Foods';
}

const contactButtonOnClick = () => {
    window.location.href = '/Contact';
}

function HeaderMenuComponent() {
    return (
        <div class="header">

            <div class="container">

                <a href="#" class="navbar-brand scroll-top">Victory</a>

                <nav class="navbar navbar-inverse" role="navigation">

                    <div class="navbar-header">

                        <button type="button" id="nav-toggle" class="navbar-toggle" data-toggle="collapse" data-target="#main-nav">
                            <span class="sr-only">Toggle navigation</span>
                            <span class="icon-bar"></span>
                            <span class="icon-bar"></span>
                            <span class="icon-bar"></span>
                        </button>

                    </div>

                    <div id="main-nav" class="collapse navbar-collapse">

                        <ul class="nav navbar-nav">
                            <li>
                                <a onClick={homeButtonOnClick}>Home</a>
                            </li>
                            <li>
                                <a onClick={menuButtonOnClick}>Menu</a>
                            </li>
                            <li>
                                <a onClick={contactButtonOnClick}>Contact Us</a>
                            </li>
                        </ul>

                    </div>

                </nav>

            </div>

        </div>
    )
}

export default HeaderMenuComponent