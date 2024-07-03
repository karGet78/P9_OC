@charset "UTF-8";
/* Animation fadeIn pour les sections */
section {
  opacity: 0;
}

section.visible {
  animation: fadeInAnimation ease-in-out 2s;
  animation-fill-mode: forwards;
}

@keyframes fadeInAnimation {
  0% {
    opacity: 0;
  }
  100% {
    opacity: 1;
  }
}
/* Animation pour les titres des sections */
/* Animation pour les titres des sections */
@keyframes slideUpFadeIn {
  0% {
    opacity: 0;
    transform: translateY(100px); /* Part de 100px en bas */
  }
  100% {
    opacity: 1;
    transform: translateY(0); /* Atteint la position finale */
  }
}
span.animation-title {
  display: inline-block;
  opacity: 0;
  transform: translateY(100px); /* Position initiale hors écran en bas */
  transition: opacity 1s ease-out, transform 1s ease-out; /* Durée de 1s */
}

span.animation-title.visible {
  opacity: 1;
  transform: translateY(0); /* Position finale */
}

/* Animation fleurs */
@keyframes rotateFlower {
  0% {
    transform: rotate(0deg);
  }
  100% {
    transform: rotate(360deg);
  }
}
:root {
  --rotation: 12s;
}

/* Appliquer l'animation à tous les pseudo-éléments nécessaires */
.story h2::after,
.story__article::after,
#studio h2::before,
#studio h2::after,
.site-footer::before,
.site-footer::after,
.site-footer ul::after {
  animation: rotateFlower var(--rotation) linear infinite;
}

/* Ajustement spécifique pour l'image de fond */
.story h2::before {
  content: url("../images/sunflower_leaves.png");
  position: absolute;
  left: 0;
  top: 1.8em;
  z-index: -1;
}

.story h2::after {
  content: url("../images/Sunflower.png");
  position: absolute;
  left: 0.7em;
  top: 6em;
}

@keyframes floatAnimation {
  0% {
    transform: translate(0);
  }
  20% {
    transform: translate(-5px, 5px);
  }
  40% {
    transform: translate(-5px, -5px);
  }
  60% {
    transform: translate(5px, 5px);
  }
  80% {
    transform: translate(5px, -5px);
  }
  100% {
    transform: translate(0);
  }
}
.banner__content img {
  display: inline-block;
  animation: floatAnimation 3s infinite ease-in-out;
  width: 200px; /* Ajustez cette valeur selon la taille souhaitée */
  height: auto; /* Maintient les proportions du logo */
}

/*# sourceMappingURL=animations.cs.map */
