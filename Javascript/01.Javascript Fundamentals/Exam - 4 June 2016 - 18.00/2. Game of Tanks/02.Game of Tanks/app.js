function solve(args) {
    var fieldSizes = args[0].split(' ').map(Number),
        fieldRows = fieldSizes[0],
        fieldCols = fieldSizes[1],
        debrisPositions = args[1].split(';'),
        numberOfCommands = +args[2],
        currentCommand = [],
        kocetoTankCount = 4,
        cukiTankCount = 4;

    // creating the field - 2D array
    var field = new Array(fieldRows);
    for(var i = 0; i < fieldRows; i+= 1) {
        field[i] = new Array(fieldCols);
    }

    // filling the field with tanks
    // Koceto's tanks
    field[0][0] = 0;
    field[0][1] = 1;
    field[0][2] = 2;
    field[0][3] = 3;
    var tank0 = field[0][0],
        tank1 = field[0][1],
        tank2 = field[0][2],
        tank3 = field[0][3];
    
    // Cuki's tanks
    field[fieldRows - 1][fieldCols - 1] = 4;
    field[fieldRows - 1][fieldCols - 2] = 5;
    field[fieldRows - 1][fieldCols - 3] = 6;
    field[fieldRows - 1][fieldCols - 4] = 7;
    var tank4 = field[fieldRows - 1][fieldCols - 1],
        tank5 = field[fieldRows - 1][fieldCols - 2],
        tank6 = field[fieldRows - 1][fieldCols - 3],
        tank7 = field[fieldRows - 1][fieldCols - 4];

    // filling the field with debris
    for(var i = 0; i < debrisPositions.length; i += 1) {
        var currentDebrisPosition = debrisPositions[i];
        var currentDebrisPositionRow = currentDebrisPosition[0];
        var currentDebrisPositionCol = currentDebrisPosition[2];

        field[currentDebrisPositionRow][currentDebrisPositionCol] = 'x';
    }

    // executing the commands
    for(var i = 0; i < numberOfCommands; i += 1) {
        if (kocetoTankCount === 0) {
            console.log("Koceto is gg");
            break;
        }
        else if (cukiTankCount === 0) {
            console.log("Cuki is gg");
            break;
        }
        currentCommand = args[i + 3];
        console.log(currentCommand);

        // moving
        if (currentCommand[0] === "mv") {
            switch (currentCommand[1]) {
                case 0:
                    switch (currentCommand[3]) {
                        case "u":
                            for(var tankR = tank1; tankR < field.length; tankR += 1) {
                                for(var tankC = 0; j < field[i].length; tankC += 1) {
                                    
                                }
                            }
                            break;
                        case "d":
                            
                            break;
                        case "l":
                            
                            break;
                        case "r":
                            
                            break;
                    
                        default:
                            break;
                    }
                    break;
                case 1:
                    
                    break;
                case 2:
                    
                    break;
                case 3:
                    
                    break;
                case 4:
                    
                    break;
                case 5:
                    
                    break;
                case 6:
                    
                    break;
                case 7:
                    
                    break;
                case 8:
                    
                    break;
            
                default:
                    break;
            }
        }
        // shooting
        else if (currentCommand[0] === "x") {
            switch (currentCommand[1]) {
                case 0:

                    break;
                case 1:
                    
                    break;
                case 2:
                    
                    break;
                case 3:
                    
                    break;
                case 4:
                    
                    break;
                case 5:
                    
                    break;
                case 6:
                    
                    break;
                case 7:
                    
                    break;
                case 8:
                    
                    break;
            
                default:
                    break;
            }
        }
    }


    // printing the field - must be removed before sending to BgCoder
    for(var i = 0; i < field.length; i += 1) {
        for(var j = 0; j < field[i].length; j += 1) {
            console.log(field[i][j] + " ");
        }
        console.log();
    }
}

solve([
    '5 5',
    '2 0;2 1;2 2;2 3;2 4',
    '13',
    'mv 7 2 l',
    'x 7 u',
    'x 0 d',
    'x 6 u',
    'x 5 u',
    'x 2 d',
    'x 3 d',
    'mv 4 1 u',
    'mv 4 4 l',
    'mv 1 1 l',
    'x 4 u',
    'mv 4 2 r',
    'x 2 d'
])