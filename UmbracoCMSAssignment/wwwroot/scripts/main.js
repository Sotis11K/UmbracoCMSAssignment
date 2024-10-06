const currentURL = window.location.href;

if (currentURL === 'https://localhost:44389/contact' || currentURL === 'https://localhost:44389/contact/') {
    document.querySelector(".section-yourProject").style.backgroundColor = "white"
} 


if (currentURL === "https://localhost:44389/about" || currentURL === 'https://localhost:44389/about/') {
    document.querySelector(".navigation-links-about").classList.add("active");

}
else if (currentURL === "https://localhost:44389/service" || currentURL === 'https://localhost:44389/service/' || currentURL === 'https://localhost:44389/riskmanagement' || currentURL === 'https://localhost:44389/riskmanagement/') {
    document.querySelector(".navigation-links-services").classList.add("active");

}
else if (currentURL === "https://localhost:44389/our-projects" || currentURL === 'https://localhost:44389/our-projects/' || currentURL === 'https://localhost:44389/annualreport' || currentURL === 'https://localhost:44389/annualreport/')  {
    document.querySelector(".navigation-links-projects").classList.add("active");

}
else if (currentURL === "https://localhost:44389/contact" || currentURL === 'https://localhost:44389/contact/') {
    document.querySelector(".navigation-links-contact").classList.add("active");

}