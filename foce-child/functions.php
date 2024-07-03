<?php
function enqueue_custom_scripts() {
    wp_enqueue_style('parent-style', get_template_directory_uri() . '/style.css');
    wp_enqueue_style('theme-styles', get_stylesheet_directory_uri() . '/assets/css/theme.css', array('parent-style'));
    wp_enqueue_style('animations-css', get_stylesheet_directory_uri() . '/assets/css/animations.css', array('parent-style'));

    wp_enqueue_script('jquery'); // Ajout de jQuery en premier
    wp_enqueue_script('animations-js', get_stylesheet_directory_uri() . '/assets/js/animations.js', array('jquery'), null, true);
}
add_action('wp_enqueue_scripts', 'enqueue_custom_scripts');

// Get customizer options from parent theme
if ( get_stylesheet() !== get_template() ) {
    add_filter( 'pre_update_option_theme_mods_' . get_stylesheet(), function ( $value, $old_value ) {
        update_option( 'theme_mods_' . get_template(), $value );
        return $old_value; // prevent update to child theme mods
    }, 10, 2 );
    add_filter( 'pre_option_theme_mods_' . get_stylesheet(), function ( $default ) {
        return get_option( 'theme_mods_' . get_template(), $default );
    } );
}
?>