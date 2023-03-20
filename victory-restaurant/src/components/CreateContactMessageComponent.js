import React from "react"

function CreateContactMessageComponent() {
    return (
        <section class="contact-us">
            <div class="container">

                <div class="row">

                    <div class="col-md-6">

                        <div class="section-heading">
                            <h2>Contact us</h2>
                        </div>

                        <form>

                            <div class="row">

                                <div class="col-md-6">
                                    <input class="form-control" type="text" placeholder="Name" required=""></input>
                                    <input class="form-control" type="email" placeholder="Email" required=""></input>
                                    <input class="form-control" type="text" placeholder="Phone" required=""></input>
                                </div>

                                <div class="col-md-6">
                                    <textarea class="form-control" rows="6" placeholder="Your message" required=""></textarea>
                                    <button type="submit" class="btn">Send</button>
                                </div>

                            </div>

                        </form>

                    </div>

                    <div class="col-md-6">

                        <div class="section-heading contact-info">
                            <h2>Information</h2>
                            <p>
                                If you have not been able to contact us. You can approach our administrator at:
                                <br></br><br></br><em>Address <br></br>City Delivery Index</em>
                            </p>
                        </div>

                    </div>

                </div>

            </div>

        </section>
    )
}

export default CreateContactMessageComponent