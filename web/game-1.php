<!doctype html>
    <html lang="en">
        <head>
            <title>Presidential Campaign - Game</title>
            <!-- Required meta tags -->
            <meta charset="utf-8">
            <meta content="width=device-width, initial-scale=1.0" name="viewport" />
            <meta http-equiv="X-UA-Compatible" content="IE=edge,chrome=1" />
            <!-- Fonts and icons -->
            <link rel="stylesheet" type="text/css" href="https://fonts.googleapis.com/css?family=Roboto:300,400,500,700|Roboto+Slab:400,700|Material+Icons" />
            <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/font-awesome/latest/css/font-awesome.min.css">
            <!-- Material Kit CSS -->
            <link href="assets/css/material-kit.css?v=2.0.7" rel="stylesheet" />
        </head>

        <body>
            <?php include('header.php'); ?>
            <div class="page-header header-filter" data-parallax="true" style="background-image: url('assets/img/game-bg.png')"></div>

            <div class="main main-raised">
                <div class="container">
                    <div class="title">
                        <div class="space-40"></div>
                        <h2>Presidential Campaign</h2>
                        <p class="text-justify">Enter your canidate information on the home screen. On the following screen, select your canidate attributes. After being elected as the president you are allowed to select a maximum of actions. The following screen will let you know whether or not you've been relected.</p>
                    </div>

                    <div id="carousel">
                        <div class="container">
                            <div class="row">
                                <div class="col-md-8 mr-auto ml-auto">

                                    <!-- Carousel Card -->
                                    <div class="card card-raised card-carousel">
                                        <div id="carouselExampleIndicators" class="carousel slide" data-ride="carousel" data-interval="3000">
                                            <ol class="carousel-indicators">
                                                <li data-target="#carouselExampleIndicators" data-slide-to="0" class="active"></li>
                                                <li data-target="#carouselExampleIndicators" data-slide-to="1"></li>
                                                <li data-target="#carouselExampleIndicators" data-slide-to="2"></li>
                                            </ol>
                                            <div class="carousel-inner">
                                                <div class="carousel-item active">
                                                    <img class="d-block w-100" src="./assets/img/gameplay/Screenshot_40.png" alt="First slide">
                                                </div>
                                                <div class="carousel-item">
                                                    <img class="d-block w-100" src="./assets/img/gameplay/Screenshot_41.png" alt="Second slide">
                                                </div>
                                                <div class="carousel-item">
                                                    <img class="d-block w-100" src="./assets/img/gameplay/Screenshot_42.png" alt="Third slide">
                                                </div>
                                            </div>
                                            <a class="carousel-control-prev" href="#carouselExampleIndicators" role="button" data-slide="prev"><i class="material-icons">keyboard_arrow_left</i><span class="sr-only">Previous</span></a>
                                            <a class="carousel-control-next" href="#carouselExampleIndicators" role="button" data-slide="next"><i class="material-icons">keyboard_arrow_right</i><span class="sr-only">Next</span></a>
                                        </div>
                                    </div>
                                    <div class="space-70"></div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class="space-50"></div>
            <?php include('footer.php'); ?>
            <?php include('back_to_top.php'); ?>
        </body>

</html>