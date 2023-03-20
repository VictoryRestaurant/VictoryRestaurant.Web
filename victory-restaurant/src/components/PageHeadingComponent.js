import React from "react"

function PageHeadingComponent(props) {
    return (
        <section class="page-heading">

    <div class="container">

        <div class="row">

            <div class="col-md-12">
                <h1>{props.header}</h1>
                <p>{props.text}</p>
            </div>

        </div>

    </div>

</section>
    )
}

export default PageHeadingComponent