namespace Admin.Review {
    export interface ReviewRow {
        Id?: number;
        Name?: string;
        Email?: string;
        Subject?: string;
        Descriptin?: string;
    }

    export namespace ReviewRow {
        export const idProperty = 'Id';
        export const nameProperty = 'Name';
        export const localTextPrefix = 'Review.Review';
        export const deletePermission = 'Review';
        export const insertPermission = 'Review';
        export const readPermission = 'Review';
        export const updatePermission = 'Review';

        export declare const enum Fields {
            Id = "Id",
            Name = "Name",
            Email = "Email",
            Subject = "Subject",
            Descriptin = "Descriptin"
        }
    }
}
