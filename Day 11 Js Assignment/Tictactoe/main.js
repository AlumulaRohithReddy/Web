const cells = document.querySelectorAll(".cell");
const statust = document.getElementById("status");
const reBtn = document.getElementById("restart");

let currentPlayer = "X";
let board = ["", "", "", "", "", "", "", "", ""];
let gameActive = true;

const winP = [
      [0,1,2], [3,4,5], [6,7,8],
      [0,3,6], [1,4,7], [2,5,8],
      [0,4,8], [2,4,6]
    ];
function handleClick(e) {
    const index = Array.from(cells).indexOf(e.target);
    if (board[index] !== "" || !gameActive) return;
      board[index] = currentPlayer;
      e.target.textContent = currentPlayer;
      check();
}
function check() {
    let roundWon = false;
    for (let pattern of winP) {
        const [a, b, c] = pattern;
    if (board[a] && board[a] === board[b] && board[a] === board[c]) {
          roundWon = true;
        break;
    }
}
    if (roundWon) {
        statust.textContent = `Player ${currentPlayer} Wins!`;
        gameActive = false;
        return;
    }

    if (!board.includes("")) {
        statust.textContent = "It's a Draw";
        gameActive = false;
        return;
    }

      currentPlayer = currentPlayer === "X" ? "O" : "X";
      statust.textContent = `Player ${currentPlayer}'s turn`;
    }

reBtn.addEventListener("click", () => {
      board = ["", "", "", "", "", "", "", "", ""];
      currentPlayer = "X";
      gameActive = true;
      statust.textContent = "Player X's turn";
      cells.forEach(cell => cell.textContent = "");
});

cells.forEach(cell => cell.addEventListener("click", handleClick));