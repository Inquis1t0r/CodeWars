String.prototype.toAlternatingCase = function () {
    return this.split('').map(char => {
        return char === char.toLowerCase() ? char.toUpperCase() : char.toLowerCase();
    }).join('');
}
