import { Injectable } from '@angular/core';
import { HubConnection, HubConnectionBuilder } from '@microsoft/signalr';
import { ToastrService } from 'ngx-toastr';
import { environment } from 'src/environments/environment';
import { UserDto } from '../_models/userDto';

@Injectable({
  providedIn: 'root'
})
export class ActivityService {

  hubUrl = environment.hubUrl;
  private hubConnection: HubConnection;

  constructor(private toastr: ToastrService) { }

  createHubConnection(user: UserDto) {
    this.hubConnection = new HubConnectionBuilder()
      .withUrl(this.hubUrl + 'activity', {
        accessTokenFactory: () => user.token
      })
      .withAutomaticReconnect()
      .build()

      this.hubConnection
      .start()
      .catch(error=>console.log(error));
      
      this.hubConnection.on('UserIsOnline', username =>{
        this.toastr.info(username + ' has connected')
      });

      this.hubConnection.on('UserIsOffline', username=>{
        this.toastr.warning(username+ ' has disconnected')
      })
  }

  stopHubConnection(){
    this.hubConnection.stop().catch(error=> console.log(error));
  }
}
