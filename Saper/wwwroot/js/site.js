// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

document.querySelectorAll('.Tile').forEach((el) => {
    el.addEventListener('contextmenu', (e) => {
        if (!el.classList.contains('red'))
            el.classList.add('red')
        else
            el.classList.remove('red')
    })
})