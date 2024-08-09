@charset "UTF-8";
/* -- Animation fadeIn pour les sections -- */
[id^=section-] {
  opacity: 0;
}

[id^=section-].visible {
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
/* -- Animation pour les mots des titres -- */
span.animation-title-word {
  display: inline-block;
  opacity: 0;
  transform: translateY(60px);
  transition: opacity 1s ease-out, transform 1s ease-out;
}

span.animation-title-word.visible {
  opacity: 1;
  transform: translateY(0);
}

/* -- Animation Rotation des fleurs -- */
@keyframes rotateFlower {
  0% {
    transform: rotate(0deg);
  }
  100% {
    transform: rotate(360deg);
  }
}
/* -- Sélection des pseudo-éléments pour l'animation fleurs -- */
.story h2::after,
.story__article::after,
#studio h2::before,
#studio h2::after,
.site-footer::after,
.site-footer ul::after {
  animation: rotateFlower 10s linear infinite;
}

/* -- Animation de flottement du logo -- */
@keyframes floatAnimation {
  0% {
    transform: translateY(0);
  }
  25% {
    transform: translateY(-30px);
  }
  50% {
    transform: translateY(-10px);
  }
  75% {
    transform: translateY(-20px);
  }
  100% {
    transform: translateY(0);
  }
}
.banner__content img {
  display: inline-block;
  animation: floatAnimation 3s infinite ease-in-out;
  width: 680px;
  height: auto;
}

/* -- Animation titres nouveau menu ouvert -- */
@keyframes animationTitreMenu {
  0% {
    opacity: 0;
    transform: translateY(200px);
  }
  20% {
    opacity: 0.5;
    transform: translateY(150px);
  }
  50% {
    opacity: 1;
    transform: translateY(80px);
  }
  100% {
    opacity: 1;
    transform: translateY(0);
  }
}
@media screen and (min-width: 700px) {
  .menu-toggle {
    display: block;
  }
}
.main-navigation {
  display: flex;
  justify-content: space-between;
  align-items: center;
}
.main-navigation .line {
  height: 2px;
  margin-block: 8px;
  width: 40px;
  background-color: black;
}
.main-navigation ul {
  height: 60%;
}

.site-title {
  list-style-type: none;
  text-align: center;
  flex: 1;
}

.closeMenu {
  margin-left: auto;
  height: 80px;
  display: flex;
  justify-content: space-between;
  align-items: center;
  width: 100%;
  position: relative;
  z-index: 1000;
}

.menu-toggle {
  margin-right: 40px !important;
  cursor: pointer;
}

.menu-toggle.cross .line:nth-child(2) {
  opacity: 0;
}

.menu-toggle.cross .line:nth-child(1) {
  transform: rotate(45deg) translate(8px, 6px);
}

.menu-toggle.cross .line:nth-child(3) {
  transform: rotate(-45deg) translate(8px, -6px);
}

.openMenu {
  display: none;
  width: 100%;
  top: 80px;
  left: 0;
  height: calc(100vh - 80px);
  background-color: #fff5e9;
  z-index: 9999;
  animation: fadeInAnimation ease-in-out 2s;
}
.openMenu.active {
  display: block;
}
.openMenu__content {
  display: flex;
  flex-direction: column;
  align-items: center;
  width: 50%;
  height: 100%;
  margin: 0 auto;
  position: relative;
}
.openMenu__content--logo {
  margin: 20px;
  width: 154px;
}
.openMenu__content ul {
  flex-direction: column;
  list-style: none;
  padding: 0;
  margin-top: 10px;
  flex: 1;
}
.openMenu__content ul li {
  margin: 20px;
  font-size: 3em;
  font-weight: 400;
  line-height: 1.4em;
  text-align: center;
}
.openMenu__content ul li a {
  animation: animationTitreMenu 2s ease-out;
}
.openMenu__content ul li:hover,
.openMenu__content ul li a:hover {
  text-shadow: 0 0 14px #ff5c00;
}
.openMenu__content ul li.story::before {
  content: url("../images/Blue-cat.png");
  position: absolute;
  top: -2em;
  left: -5em;
  transform: rotate(17.86deg);
}
.openMenu__content ul li.story::after {
  content: url("../images/Sunflower.png");
  position: absolute;
  top: -3em;
  left: 10em;
  animation: rotateFlower 10s linear infinite;
}
.openMenu__content ul li.characters::before {
  content: url("../images/Small-flower.png");
  position: absolute;
  top: 1em;
  left: -8em;
  animation: rotateFlower 10s linear infinite;
}
.openMenu__content ul li.characters::after {
  content: url("../images/Grey-cat.png");
  position: absolute;
  top: 9em;
  left: 2em;
}
.openMenu__content ul li.place::before {
  content: url("../images/Orange-cat.png");
  position: absolute;
  top: 2em;
  left: -3em;
  transform: rotate(17.86deg);
}
.openMenu__content ul li.place::after {
  content: url("../images/Small-random-flower.png");
  position: absolute;
  top: 15em;
  left: -1em;
  animation: rotateFlower 10s linear infinite;
}
.openMenu__content ul li.studio::before {
  content: url("../images/orchid.png");
  position: absolute;
  top: -9em;
  left: -12.5em;
  animation: rotateFlower 10s linear infinite;
}
.openMenu__content ul li.studio::after {
  content: url("../images/hibiscus_footer.png");
  position: absolute;
  top: -2em;
  left: 9em;
  animation: rotateFlower 10s linear infinite;
}
.openMenu__content--footer {
  width: 100%;
  text-align: center;
  padding-bottom: 20px;
}

/*# sourceMappingURL=newMenu.cs.map */
