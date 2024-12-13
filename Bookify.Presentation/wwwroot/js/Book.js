$(document).ready(function () {

    var DescriptionLink = document.querySelector(".Description-link");
    var CopiesLink = document.querySelector(".Copies-link");
    var table = document.querySelector(".js-table");
    var des = document.querySelector(".js-des");

    CopiesLink.classList.add('active');

    DescriptionLink.addEventListener("click", function () {
        des.removeAttribute("class");
        table.setAttribute("class", "d-none");

        CopiesLink.classList.remove('active');
        this.classList.add('active');
    })

    CopiesLink.addEventListener("click", function () {
        des.setAttribute("class", "d-none");
        table.removeAttribute("class");

        DescriptionLink.classList.remove('active');
        this.classList.add('active');
    })
})
