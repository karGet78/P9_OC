<?php
get_header();
?>

<main id="primary" class="site-main">
<section id="section-banner" class="banner">
    <div class="background">
        <video id="background-video" autoplay loop muted>
            <source src="<?php echo get_stylesheet_directory_uri() . '/assets/video/video-Koukaki.mp4'; ?>" type="video/mp4">
            <img src="<?php echo get_stylesheet_directory_uri() . '/assets/images/banner.png'; ?>" alt="studio koukaki">
        </video>
    </div>
    <div class="banner__content" id="parallax-logo">
        <img src="<?php echo get_template_directory_uri() . '/assets/images/logo.png'; ?>" alt="logo Fleurs d'oranger & chats errants">
    </div>
</section>

<section id="section-story" class="story">
    <h2 class="title">L'histoire</h2>
    <article class="story__article">
        <p><?php echo get_theme_mod('story'); ?></p>
    </article>
    <?php
    $args = array(
        'post_type' => 'characters',
        'posts_per_page' => -1,
        'meta_key'  => '_main_char_field',
        'orderby'   => 'meta_value_num',
    );
    $characters_query = new WP_Query($args);
    ?>
    <article id="characters">
            <?php get_template_part('templates/characters-carousel'); ?>
            </article>

    <article id="place">
  <div>
    <h3 class="title title-mobile-specific">Le Lieu</h3>
    <div class="place__nuages">
      <img id="grand-nuage" class="big-cloud" src="<?php echo get_stylesheet_directory_uri() . '/assets/images/big_cloud.png'; ?>" alt="Grand Nuage">
      <img id="petit-nuage" class="little-cloud" src="<?php echo get_stylesheet_directory_uri() . '/assets/images/little_cloud.png'; ?>" alt="Petit Nuage">
    </div>
    <p><?php echo get_theme_mod('place'); ?></p>
  </div>
</article>
</section>

<!-- <section id="section-studio" class="studio"> -->
<section id="studio" class="section-studio">
    <h2 class="title">Studio Koukaki</h2>
    <div>
        <p>Acteur majeur de l’animation, Koukaki est un studio intégré fondé en 2012 qui créé, produit et distribue des programmes originaux dans plus de 190 pays pour les enfants et les adultes. Nous avons deux sections en activité : le long métrage et le court métrage. Nous développons des films fantastiques, principalement autour de la culture de notre pays natal, le Japon.</p>
        <p>Avec une créativité et une capacité d’innovation mondialement reconnues, une expertise éditoriale et commerciale à la pointe de son industrie, le Studio Koukaki se positionne comme un acteur incontournable dans un marché en forte croissance. Koukaki construit chaque année de véritables succès et capitalise sur de puissantes marques historiques. Cette année, il vous présente “Fleurs d’oranger et chats errants”.</p>
    </div>
</section>

<!-- Section nomination Oscar -->
<?php get_template_part('templates/oscar'); ?>
<!-- <section id="nomination"> -->
</main><!-- #main -->

<?php
get_footer();
?>