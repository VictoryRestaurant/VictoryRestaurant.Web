import React from "react"

function BookingComponent() {
    return (
        <section id="book-table">

            <div class="container mt-5">

                <div class="row d-flex justify-content-center align-items-center">

                    <div class="col-md-12">

                        <form id="regForm" style={{ width: "60%" }}>


                            <h1 id="register">Book a table right now!</h1>

                            <div class="all-steps" id="all-steps">

                                <span class="step"><i class="fa fa-calendar"></i></span>
                                <span class="step"><i class="fa fa-clock-o"></i></span>
                                <span class="step"><i class="fa fa-users"></i></span>
                                <span class="step"><i class="fa fa-mobile"></i></span>
                                <span class="step"><i class="fa fa-user-circle"></i></span>

                            </div>

                            <div class="tab">

                                <h6>On what day do you want to book?</h6>
                                <p>
                                    <input type="date" asp-for="Date" placeholder="Date" oninput="this.className = ''" id="bookingFormDate"></input>
                                </p>

                            </div>

                            <div class="tab">

                                <h6>What time do you want to book for</h6>
                                <p>
                                    <input type="time" placeholder="Time" oninput="this.className = ''"></input>
                                </p>

                            </div>

                            <div class="tab">

                                <h6>Person count</h6>
                                <p>
                                    <input type="number" placeholder="Person count" oninput="this.className = ''" id="bookingFormPersonCount"></input>
                                </p>

                            </div>

                            <div class="tab">

                                <h6>Your phone number.</h6>
                                <p>
                                    <input type="tel" placeholder="Telephone" oninput="this.className = ''" id="bookingFormPhone"></input>
                                </p>

                            </div>

                            <div class="tab">

                                <h6>Your name.</h6>
                                <p>
                                    <input placeholder="Name" oninput="this.className = ''"></input>
                                </p>

                            </div>

                            <div class="thanks-message text-center" id="text-message">
                                <img src="https://i.imgur.com/O18mJ1K.png" width="100" class="mb-4"></img>

                                <h3>Almost finished!</h3>
                                <span>Send a request and wait for the call!</span>
                                <button type="submit" class="btn" style={{ marginTop: "5%" }}>Book!</button>

                            </div>

                            <div style={{ overflow: "auto" }} id="nextprevious">

                                <div style={{ float: "right" }}>

                                    <button type="button" id="prevBtn" >
                                        <i class="fa fa-angle-double-left"></i>
                                    </button>

                                    <button type="button" id="nextBtn" >
                                        <i class="fa fa-angle-double-right"></i>
                                    </button>

                                </div>

                            </div>
                        </form>

                    </div>

                </div>

            </div>

        </section>
    )
}

export default BookingComponent