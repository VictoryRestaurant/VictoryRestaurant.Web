import React from "react"

function FooterComponent() {
    return (
        <footer>

            <div class="container">

                <div class="row">

                    <div class="col-md-4">

                        <p>
                            &copy; {new Date().toJSON().slice(0, 4)}
                            <a href="https://templatemo.com/tm-507-victory"> Victory</a>
                            by
                            <a href="https://github.com/DimaInNature"> DimaInNature</a>
                        </p>

                    </div>

                    <div class="col-md-4">

                        <ul class="social-icons">
                            <li>
                                <a href="https://github.com/DimaInNature" target="_blank">
                                    <i class="fa fa-github"></i>
                                </a>
                            </li>
                            <li>
                                <a href="https://vk.com/feed" target="_blank">
                                    <i class="fa fa-vk"></i>
                                </a>
                            </li>
                            <li>
                                <a href="https://telegram.org/" target="_blank">
                                    <i class="fa fa-telegram"></i>
                                </a>
                            </li>
                        </ul>

                    </div>

                    <div class="col-md-4">

                        <p>
                            Work around the clock. 24/7.
                        </p>

                    </div>

                </div>

            </div>

        </footer>
    )
}

export default FooterComponent