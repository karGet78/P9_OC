document.addEventListener('DOMContentLoaded', function () {
  // Fonction pour vérifier si un élément est visible dans le viewport
  function ifElementInViewport(element) {
    const elementRect = element.getBoundingClientRect();
    return elementRect.top < window.innerHeight && elementRect.bottom >= 0;
  }

  // Fonction pour ajouter la classe visible aux sections
  function showVisibleSections() {
    const sections = document.querySelectorAll('[id^="section-"]');
    sections.forEach(function (section) {
      if (ifElementInViewport(section)) {
        section.classList.add('visible');
      }
    });
  }

  // Fonction pour ajouter la classe visible aux mots des titres
  function animateTitleWords() {
    const titles = document.querySelectorAll('h2.title, h3.title');
    titles.forEach(function (title) {
      if (ifElementInViewport(title) && !title.classList.contains('animated')) {
        const words = title.textContent.split(' ');
        title.innerHTML = ''; // Efface le contenu actuel du titre
        words.forEach(function (word, index) {
          const span = document.createElement('span');
          span.className = 'animation-title-word';
          span.textContent = word;
          title.appendChild(span);
          if (index < words.length - 1) {
            title.appendChild(document.createTextNode(' ')); // Ajoute un espace après chaque mot sauf le dernier
          }
        });

        const spans = title.querySelectorAll('.animation-title-word');
        spans.forEach(function (span, index) {
          setTimeout(function () {
            span.classList.add('visible');
          }, 200 + index * 300); // Délai initial + délai entre chaque mot
        });

        // Ajouter une classe pour marquer que l'animation a été exécutée
        title.classList.add('animated');
      }
    });
  }

  // Effet de parallaxe pour le logo
  const parallaxLogo = document.getElementById('parallax-logo');

  function parallaxEffect() {
    const scrollTop = window.scrollY || document.documentElement.scrollTop;
    const speed = 0.5; // Vitesse de l'effet de parallaxe
    parallaxLogo.style.transform = `translateY(${scrollTop * speed}px)`;
  }

  // Effet de déplacement des nuages
  function moveClouds() {
    const bigCloud = document.getElementById('grand-nuage');
    const littleCloud = document.getElementById('petit-nuage');
    const scrollTop = window.scrollY || document.documentElement.scrollTop;
    const cloudMove = scrollTop / 2; // Vitesse du mouvement des nuages

    bigCloud.style.transform = `translateX(-${cloudMove}px)`;
    littleCloud.style.transform = `translateX(-${cloudMove}px)`;
  }

  window.addEventListener('scroll', function () {
    showVisibleSections();
    animateTitleWords();
    parallaxEffect();
    moveClouds();
  });

  // Initialisation lors du chargement de la page
  showVisibleSections();
  animateTitleWords();
  parallaxEffect();
  moveClouds();

  // Initialisation de Swiper
  const swiper = new Swiper('.characters-slider', {
    effect: 'coverflow',
    grabCursor: true, // fait apparaitre une main pour glisse diapos
    centeredSlides: true, // Centrer diapo active dans le carrousel
    slidesPerView: 'auto', // ajuste automatiquement le nombre de diapo en fonction taille
    coverflowEffect: {
      // rotate: 50,
      stretch: 0, // Ne pas étirer les diapos
      depth: 100, // effet 3D - profondeur de 100px aux diapos
      modifier: 1,
      slideShadows: false, // Ne pas afficher les ombres sur les diapos
    },
    autoplay: {
      delay: 3000,
      disableOnInteraction: false, // Autoplay continue même si l'utilisateur interagit avec le carrousel
    },
    loop: true, // boucle diapos
  });
});

