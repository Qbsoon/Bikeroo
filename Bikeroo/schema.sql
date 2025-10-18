-- Tworzenie tabeli stations
CREATE TABLE stations (
	Id INTEGER NOT NULL PRIMARY KEY,
	name TEXT NOT NULL
);

-- Tworzenie tabeli users
CREATE TABLE users (
	Id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
	username TEXT NOT NULL,
	password TEXT NOT NULL,
	type INTEGER NOT NULL DEFAULT 2,
	balance REAL NOT NULL DEFAULT 0
);

-- Tworzenie tabeli bikes
CREATE TABLE bikes (
	Id INTEGER NOT NULL PRIMARY KEY,
	model TEXT NOT NULL,
	station INTEGER NOT NULL,
	statusBorrowed INTEGER,
	statusMaintenance INTEGER,
	FOREIGN KEY (station) REFERENCES stations(Id),
	FOREIGN KEY (statusBorrowed) REFERENCES users(Id),
	FOREIGN KEY (statusMaintenance) REFERENCES users(Id)
);

-- Wstawienie użytkowników
INSERT INTO users (username, password, type, balance)
VALUES ('test', 'test', 2, 0), 
('user', 'user', 2, 100),
('engineer', '123', 1, 0),
('admin', 'admin', 0, 0);