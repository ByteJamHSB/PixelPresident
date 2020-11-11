<!doctype html>
<html lang="en">
<head>
  <title>Hackstreet Boys</title>
  <!-- Required meta tags -->
  <meta charset="utf-8">
  <meta content="width=device-width, initial-scale=1.0" name="viewport" />
  <meta http-equiv="X-UA-Compatible" content="IE=edge,chrome=1" />
  <!--     Fonts and icons     -->
  <link rel="stylesheet" type="text/css" href="https://fonts.googleapis.com/css?family=Roboto:300,400,500,700|Roboto+Slab:400,700|Material+Icons" />
  <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/font-awesome/latest/css/font-awesome.min.css">
  <!-- Material Kit CSS -->
  <link href="assets/css/material-kit.css?v=2.0.7" rel="stylesheet" />
</head>

<body>
<?php include('header.php'); ?>
  <div class="page-header header-filter" data-parallax="true" style="background-image: url('assets/img/pattern.png')">
    <div class="container">
      <div class="row">
        <div class="col-md-8 ml-auto mr-auto">
          <div class="brand text-center">
            <h1 class="text-danger title">Hackstreet</h1>
            <h3 class="title text-center text-danger">ByteJam 2020</h3>
		      </div> 
			  </div> 
		  </div> 
		</div> 
  </div> 
  
  <div class="main main-raised">
      <div class="container">
        <div id="images">
        <div class="space-50"></div>
        <br>
          <div class="row">
            <div id="nav-tabs">
              <h3>Hackstreet Boys<h3>
            </div>
          </div>

            <div class="row">
              <?php include('row-1.php'); ?>
            </div>  <!-- END .row -->

            <div class="row">
              <?php include('row-2.php'); ?>
            </div>  <!-- END .row -->

            <div class="row">
              <?php include('row-3.php'); ?>
            </div>  <!-- END .row -->

            <div class="row">
              <?php include('row-4.php'); ?>
            </div>  <!-- END .row -->

          </div>
        </div>
      <div class="space-110"></div>
  </div>

  <div class="space-40"></div>
  <?php include('footer.php'); ?>
  <?php include('back_to_top.php'); ?>
</body>

</html>
