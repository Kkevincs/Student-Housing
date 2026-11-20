// Loads a file's HTML into the element with the given id.
// Skips silently if the page doesn't have that element.
async function include(id, file) {
  const element = document.getElementById(id);
  if (!element) return;
  try {
    const result = await fetch(file);
    if (!result.ok) throw new Error(result.status);
    element.innerHTML = await result.text();
  } catch (err) {
    element.textContent = `Could not load ${file}`;
  }
}

// Marks the nav link for the current page as active.
// A page can set <body data-section="chores"> so sub-pages
// (add_chore, edit_chore...) still highlight their main tab.
function highlightCurrentLink() {
  const page = location.pathname.split("/").pop() || "index.html";
  const section = document.body.dataset.section;
  document.querySelectorAll(".site-header nav a, .site-header .profile-link").forEach(a => {
    const matchesPage = a.getAttribute("href") === page;
    const matchesSection = section && a.dataset.section === section;
    if (matchesPage || matchesSection) {
      a.classList.add("active");
      a.setAttribute("aria-current", "page");
    }
  });
}

// <div id="header" data-src="admin_header.html"> loads the admin header instead
const headerEl = document.getElementById("header");
const headerFile = (headerEl && headerEl.dataset.src) || "header.html";

include("header", headerFile).then(highlightCurrentLink);
