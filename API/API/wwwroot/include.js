// Loads a file's HTML into the element with the given id
async function include(id, file) {
  const element = document.getElementById(id);
  try {
    const result = await fetch(file);
    if (!result.ok) throw new Error(result.status);
    element.innerHTML = await result.text();
  } catch (err) {
    element.textContent = `Could not load ${file}`;
  }
}

// Marks the link for the current page as active
function highlightCurrentLink() {
  const page = location.pathname.split("/").pop() || "index.html";
  document.querySelectorAll(".site-header nav a").forEach(a => {
    if (a.getAttribute("href") === page) a.classList.add("active");
  });
}

Promise.all([
  include("header", "header.html"),
  include("footer", "footer.html"),
]).then(highlightCurrentLink);