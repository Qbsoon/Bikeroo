-- Tworzenie tabeli stations
CREATE TABLE stations (
	Id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
	name TEXT NOT NULL
);

-- Tworzenie tabeli users
CREATE TABLE users (
	Id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
	username TEXT NOT NULL UNIQUE,
	password TEXT NOT NULL,
	type INTEGER NOT NULL DEFAULT 2,
	balance REAL NOT NULL DEFAULT 0,
	points REAL NOT NULL DEFAULT 0
);

-- Tworzenie tabeli bikes
CREATE TABLE bikes (
	Id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
	model TEXT NOT NULL,
	station INTEGER NOT NULL,
	statusBorrowed INTEGER,
	statusMaintenance INTEGER,
	FOREIGN KEY (station) REFERENCES stations(Id),
	FOREIGN KEY (statusBorrowed) REFERENCES users(Id),
	FOREIGN KEY (statusMaintenance) REFERENCES users(Id)
);
-- Tworzenie tabeli zgłoszeń
CREATE TABLE reports (
	Id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
	title TEXT NOT NULL,
	body TEXT NOT NULL,
	type INTEGER NOT NULL DEFAULT 0,
	state INTEGER NOT NULL DEFAULT 0,
	reportingUser INTEGER NOT NULL,
	handlingUser INTEGER NOT NULL,
	FOREIGN KEY (reportingUser) REFERENCES users(Id),
	FOREIGN KEY (handlingUser) REFERENCES users(Id)
);

-- Wstawienie użytkowników
INSERT INTO users (username, password, type, balance)
VALUES ('test', 'test', 2, 0), 
('user', 'user', 2, 100),
('engineer', '123', 1, 0),
('admin', 'admin', 0, 0);

-- Wstawienie stacji
INSERT INTO stations (name)
VALUES ('Centrum1'), 
('Centrum2'), 
('Felin1'), 
('Felin2');

-- Wstawienie rowerów
INSERT INTO bikes (model, station)
VALUES ('VHS500', 1), 
('VHS700', 1), 
('VHS500', 2), 
('PRL100', 2), 
('Q11', 3), 
('PRL350', 3), 
('MS365', 4),
('Q77', 4);

-- Wstawienie naprawianych rowerów
INSERT INTO bikes (model, station, statusMaintenance)
VALUES ('Q11', 3, 3), 
('PRL350', 3, 3), 
('MS365', 4, 3), 
('MS365', 4, 2);

-- Wstawienie wypożyczonych rowerów
INSERT INTO bikes (model, station, statusBorrowed)
VALUES ('Q11', 3, 1), 
('VHS700', 3, 2), 
('VHS500', 4, 2), 
('PRL100', 4, 2);

-- Wstawienie zgłoszeń
INSERT INTO reports (title, body, type, state, reportingUser, handlingUser)
VALUES ('Awaria stacji','Stacja zepsuła się',1,0,2,0), 
('Awaria systemu','Nie mogę się zalogować',1,0,0,4);