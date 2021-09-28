import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { faArrowUp, faArrowDown, faArrowLeft, faArrowRight } from '@fortawesome/free-solid-svg-icons';
import { ToastrService } from 'ngx-toastr';
import { IngameSessionDto } from 'src/app/_models/SessionDtos/ingameSessionDto';
import { GameBoardService } from '../../services/game-board.service';

@Component({
  selector: 'app-game-board',
  templateUrl: './game-board.component.html',
  styleUrls: ['./game-board.component.scss']
})
export class GameBoardComponent implements OnInit {
  arrowUp = faArrowUp;
  arrowDown = faArrowDown;
  arrowLeft = faArrowLeft;
  arrowRight = faArrowRight;

  sessionData : IngameSessionDto;
  renderWindow: BlockWindow  = {
    startX : 7,
    startY: 9,
    endX: 15,
    endY: 13
  }
  constructor(private gameBoardService : GameBoardService, private toastr: ToastrService, private router: Router) { }

  ngOnInit(): void {
    this.loadGame();
  }

  loadGame(){
    this.gameBoardService.getGameSessions(this.renderWindow).subscribe(response=>{
      this.sessionData = response;
      //console.log(this.sessionData);
    }, error =>{
      this.toastr.error(error.error);
    });
  }

  moveUp(){

    this.renderWindow.startY--;
    this.renderWindow.endY--;

    this.loadGame();
    console.log(this.renderWindow);
  }
  moveDown(){

    this.renderWindow.startY++;
    this.renderWindow.endY++;
    this.loadGame();
    console.log(this.renderWindow);
  }
  moveLeft(){
    console.log("moveleft");

    this.renderWindow.startX--;
    this.renderWindow.endX--;

    this.loadGame();
    console.log(this.renderWindow);
  }
  moveRight(){
    console.log("moveRight");

    this.renderWindow.startX++;
    this.renderWindow.endX++;

    this.loadGame();
    console.log(this.renderWindow);
  }

  leaveSession(){
    this.gameBoardService.leaveSession().subscribe(()=>{
      this.router.navigateByUrl('/game');
    }, error =>{
      this.toastr.error(error.error);
    });
  }
}

export interface BlockWindow{
  startX:number;
  endX:number;
  startY:number;
  endY:number;
}
