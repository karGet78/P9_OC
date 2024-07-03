document.addEventListener('DOMContentLoaded', function() {
  // Fonction pour vérifier si un élément est visible dans le viewport
  function ifElementInViewport(element) {
    const elementRect = element.getBoundingClientRect();
    return elementRect.top < window.innerHeight && elementRect.bottom >= 0;
  }

  // Fonction pour ajouter la classe visible aux sections
  function showVisibleSections() {
    const sections = document.querySelectorAll('[id^="section-"]');
    sections.forEach(function(section) {
      if (ifElementInViewport(section)) {
        section.classList.add('visible');
      }
    });
  }

  // Fonction pour ajouter la classe visible aux mots des titres
  function animateTitleWords() {
    const titles = document.querySelectorAll('h2.title, h3.title');
    titles.forEach(function(title) {
      if (ifElementInViewport(title) && !title.classList.contains('animated')) {
        const words = title.textContent.split(' ');
        title.innerHTML = '';
        words.forEach(function(word, index) {
          const span = document.createElement('span');
          span.className = 'animation-title-word';
          span.textContent = word;
          title.appendChild(span);

          // Ajout d'un espace après chaque mot sauf le dernier
          if (index < words.length - 1) {
            const space = document.createElement('span');
            space.textContent = ' ';
            title.appendChild(space);
          }
        });

        const spans = title.querySelectorAll('.animation-title-word');
        spans.forEach(function(span, index) {
          setTimeout(function() {
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
    const speed = 0.5; // Ajustez cette valeur pour changer la vitesse de l'effet de parallaxe
    parallaxLogo.style.transform = `translateY(${scrollTop * speed}px)`;
  }

  // Effet de déplacement des nuages
  const bigCloud = document.getElementById('grand-nuage');
  const littleCloud = document.getElementById('petit-nuage');

  function moveClouds() {
    const scrollTop = window.scrollY || document.documentElement.scrollTop;
    const maxScroll = 300; // Amplitude du déplacement en pixels
    const initialBigCloudPosition = 300; // Position initiale des grands nuages
    const initialLittleCloudPosition = 300; // Position initiale des petits nuages

    const bigCloudTransform = Math.max(initialBigCloudPosition - scrollTop, 0);
    const littleCloudTransform = Math.max(initialLittleCloudPosition - scrollTop, 0);

    bigCloud.style.transform = `translateX(${bigCloudTransform}px)`;
    littleCloud.style.transform = `translateX(${littleCloudTransform}px)`;
  }

  window.addEventListener('scroll', function() {
    showVisibleSections();
    animateTitleWords();
    parallaxEffect();
    moveClouds(); // Ajout de l'effet de déplacement des nuages lors du défilement
  });

  // Vérifie les éléments au chargement de la page
  showVisibleSections();
  animateTitleWords();
  parallaxEffect();
  moveClouds(); // Ajout de l'effet de déplacement des nuages lors du chargement initial
});
