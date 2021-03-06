import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';
import { UserDto } from '../../_models/userDto';
import { AccountService } from '../../home/services/account/account.service';
import { Router } from '@angular/router';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-navbar',
  templateUrl: './navbar.component.html',
  styleUrls: ['./navbar.component.scss']
})
export class NavbarComponent implements OnInit {

  currentUser$: Observable<UserDto>;
  model: any = {
    username: "",
    password: "",
  }
  constructor( private accountService: AccountService, private router:Router, private toastr: ToastrService) { }

  ngOnInit(): void {
    this.currentUser$ = this.accountService.currentUsers$;
    console.log(this.currentUser$);
  }

  login(){
    this.accountService.login(this.model).subscribe(response => {
      this.router.navigateByUrl('/game');
      console.log(response);
    }, error =>{
      console.log(error);
      this.toastr.error(error.error);
    });
  }

  logout(){
    this.accountService.logout();
  }
}
