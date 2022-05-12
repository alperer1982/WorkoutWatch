import React,{Component} from 'react';
import { variables } from './Variables.js';
export class Workout extends Component{
    constructor(props){
        super(props);
        this.state={
            exercises:[]
        }
    }
    refreshList(){
        fetch(variables.API_URL+'workout')
        .then(response=>response.json())
        .then(data=>{
            this.setState({exercises:data.Exercises})
        })
    }
    componentDidMount(){
        this.refreshList();
    }
    render(){
        const{
            exercises
        }=this.state;
        return(
            <table className="table table-striped">
                <thead>
                <tr>
                    <th>
                        Name
                    </th>
                    <th>
                        Sets
                    </th>
                    <th>
                        Reps
                    </th>
                    <th>
                        Weight
                    </th>
                </tr>
                </thead>
                <tbody>
                    {exercises.map(exercise=>
                        <tr key={exercise.Id}>
                            <td>{exercise.Name}</td>
                            <td>{exercise.Sets}</td>
                            <td>{exercise.Reps}</td>
                            <td>{exercise.Weight}</td>
                        </tr>
                            )}
                </tbody>
            </table>
        )
    }
}