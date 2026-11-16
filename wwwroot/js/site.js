// Flip cards: click / Enter / Space toggles the project preview.
document.addEventListener('click', function (e) {
    var card = e.target.closest('.flip-card');
    if (!card || e.target.closest('a')) return;
    toggle(card);
});

document.addEventListener('keydown', function (e) {
    if (e.key !== 'Enter' && e.key !== ' ') return;
    var card = e.target.closest('.flip-card');
    if (!card) return;
    e.preventDefault();
    toggle(card);
});

function toggle(card) {
    var flipped = card.classList.toggle('is-flipped');
    card.setAttribute('aria-pressed', flipped ? 'true' : 'false');
}
