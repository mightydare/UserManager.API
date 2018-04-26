import { inject } from 'aurelia-framework';
import { HttpClient } from 'aurelia-fetch-client';

@inject(HttpClient)
export class Users {
    public users: User[];
    constructor(http: HttpClient) {
        http.fetch("api/users")
            .then(result => result.json() as Promise<User[]>)
            .then(data => {
                this.users = data;
            })
    }
}

interface User {
    name: string;
    surname: string;
    age: number;
    index: number;
}       