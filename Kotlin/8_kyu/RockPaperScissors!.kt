fun rps(p1: String, p2: String): String {
    if (p1 == p2) return "Draw!"

    val beats = mapOf(
        "rock" to "scissors",
        "scissors" to "paper",
        "paper" to "rock"
    )

    return if (beats[p1] == p2) "Player 1 won!" else "Player 2 won!"
}
