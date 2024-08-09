document.addEventListener('DOMContentLoaded', function () {
  const menuToggle = document.querySelector('.menu-toggle');
  const openMenu = document.querySelector('.openMenu');
  const body = document.body;

  menuToggle.addEventListener('click', function () {
    const isActive = openMenu.classList.contains('active');
    if (isActive) {
      openMenu.classList.remove('active');
      menuToggle.classList.remove('cross');
      body.style.overflow = ''; // Enable scrolling
    } else {
      openMenu.classList.add('active');
      menuToggle.classList.add('cross');
      body.style.overflow = 'hidden'; // Disable scrolling
    }
  });

  const menuLinks = document.querySelectorAll('.openMenu ul li a');

  menuLinks.forEach((link) => {
    link.addEventListener('click', function () {
      openMenu.classList.remove('active');
      menuToggle.classList.remove('cross');
      body.style.overflow = ''; // Enable scrolling
    });
  });
});
