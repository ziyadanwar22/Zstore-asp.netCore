namespace Admin.souqcom {
    export interface CategoryRow {
        Id?: number;
        Name?: string;
        Photo?: string;
        Description?: string;
    }

    export namespace CategoryRow {
        export const idProperty = 'Id';
        export const nameProperty = 'Name';
        export const localTextPrefix = 'souqcom.Category';
        export const lookupKey = 'souqcom.Category';

        export function getLookup(): Q.Lookup<CategoryRow> {
            return Q.getLookup<CategoryRow>('souqcom.Category');
        }
        export const deletePermission = 'Category';
        export const insertPermission = 'Category';
        export const readPermission = 'Category';
        export const updatePermission = 'Category';

        export declare const enum Fields {
            Id = "Id",
            Name = "Name",
            Photo = "Photo",
            Description = "Description"
        }
    }
}
