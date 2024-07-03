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
@keyframes slideUpFadeIn {
  0% {
    opacity: 0;
    transform: translateY(100px);
  }
  100% {
    opacity: 1;
    transform: translateY(0);
  }
}
span.animation-title {
  display: inline-block;
  opacity: 0;
  transform: translateY(100px);
  transition: opacity 1s ease-out, transform 1s ease-out;
}

span.animation-title.visible {
  opacity: 1;
  transform: translateY(0);
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
    transform: translateY(0);
  }
  50% {
    transform: translateY(-10px);
  }
  100% {
    transform: translateY(0);
  }
}
.banner__content img {
  display: inline-block;
  animation: floatAnimation 3s infinite ease-in-out;
  width: 680px; /* Ajustez cette valeur selon la taille souhaitée */
  height: auto; /* Maintient les proportions du logo */
}

.oscar {
  margin-top: 2em;
  display: flex;
  position: relative;
  justify-content: center;
  align-items: center;
}
.oscar .oscar__texte {
  width: 752px;
  height: 450px;
  font-size: 2.8rem;
  font-family: "Quicksand", sans-serif;
  font-weight: 700;
  line-height: 53px;
  letter-spacing: -0.02em;
  background-image: url("../images/orange_oscar_bg.png");
  background-position: center;
  background-size: contain;
  color: #fff5e9;
  text-shadow: 2px 2px 4px rgba(0, 0, 0, 0.3);
  padding-top: 3.4em;
  text-align: left;
}
.oscar .oscar__texte::before {
  content: url("../images/Sunflower.png");
  position: absolute;
  left: 1.5em;
  top: 0em;
  animation: rotateFlower var(--rotation) linear infinite;
}
.oscar .oscar__logo {
  width: 278px;
  height: 129px;
}
.oscar .oscar__logo::after {
  content: url("../images/orchid.png");
  position: absolute;
  right: -5em;
  bottom: 20em;
  animation: rotateFlower var(--rotation) linear infinite;
}

.site-footer::before,
.site-footer::after {
  display: none;
}

.banner {
  position: relative;
  overflow: hidden;
  height: 100vh;
}

.background {
  position: absolute;
  top: 0;
  left: 0;
  width: 100%;
  height: 100%;
  z-index: -1;
}

#background-video {
  width: 100%;
  height: 100%;
  object-fit: cover;
  position: absolute;
  top: 0;
  left: 0;
}

.banner__content {
  position: absolute;
  top: 50%;
  left: 50%;
  transform: translate(-50%, -50%);
  text-align: center;
  color: white;
  z-index: 1;
  display: flex;
  align-items: center;
  justify-content: center;
}

.banner__content img {
  display: inline-block;
  animation: floatAnimation 3s infinite ease-in-out;
  width: 680px; /* Ajustez cette valeur selon la taille souhaitée */
  height: auto; /* Maintient les proportions du logo */
}

@media only screen and (max-width: 700px) {
  #background-video {
    display: none;
  }
  .background {
    background-image: url("../images/banner.png");
    background-size: cover;
    background-position: center;
  }
}

/*# sourceMappingURL=theme.cs.map */
